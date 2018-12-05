using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AssessmentHelperLib
{
    [DataContract(Name = "Question")]
    public class Question : IExtensibleDataObject
    {
        [DataMember]
        private List<Choice> m_choices = new List<Choice>();

        [DataMember]
        private List<Answer> m_answers = new List<Answer>();

        public Question( string a_text, List<string> a_choices, int a_choicesNeeded )
        {
            Text = a_text;
            NbChoicesNeeded = a_choicesNeeded;

            foreach (var choice in a_choices)
                m_choices.Add(new Choice(choice));
            m_choices.Sort((a, b) => string.Compare(a.Text, b.Text, StringComparison.InvariantCultureIgnoreCase));

            FillAnswers();
        }

        [DataMember]
        public string Text { get; private set; }

        [DataMember]
        public int NbChoicesNeeded { private set; get; }

        public bool Solved
        {
            get
            {
                return null != m_answers.Find((a_answer) => a_answer.Correct);
            }
        }

        public int NbAnswersOpen
        {
            get
            {
                return m_answers.Count((answer) => !answer.Checked && !answer.Correct);
            }
        }

        public List<Tuple<string,bool>> GetRandomAnswer()
        {
            var result = new List<Tuple<string, bool>>();
            if (m_answers.Count == 0)
                return result;

            var answer = m_answers.Find((a_answer) => a_answer.Correct);
            if (answer==null)
            {
                var notChecked = m_answers.FindAll((a_answer) => !a_answer.Checked && !a_answer.Correct);
                if ( notChecked == null || notChecked.Count == 0)
                {
                    m_answers.ForEach((a_asw) => a_asw.Checked = false);
                    notChecked = m_answers.FindAll((a_answer) => !a_answer.Checked && !a_answer.Correct);
                }

                answer = notChecked[new Random().Next(notChecked.Count)];
            }

            for( int idx = 0; idx < m_choices.Count; idx++ )
            {
                string text = m_choices[idx].Text;
                bool check = answer.ChoiceSet(idx);

                result.Add(new Tuple<string, bool>(text, check));
            }

            return result;
        }


        public List<Tuple<string, bool>> GetSolutionOrChoices()
        {
            var result = new List<Tuple<string, bool>>();
            if (m_answers.Count == 0)
                return result;

            var answer = m_answers.Find((a_answer) => a_answer.Correct);
            if (answer != null)
            {
                for (int idx = 0; idx < m_choices.Count; idx++)
                {
                    string text = m_choices[idx].Text;
                    bool check = answer.ChoiceSet(idx);

                    result.Add(new Tuple<string, bool>(text, check));
                }
            }
            else
            {
                for (int idx = 0; idx < m_choices.Count; idx++)
                {
                    string text = m_choices[idx].Text;
                    result.Add(new Tuple<string, bool>(text, false));
                }
            }
            return result;
        }

        public void AddResult(bool a_solved, List<Tuple<string,bool>> a_answers)
        {
            List<string> allChoices = new List<string>();
            List<int> choiceIndizes = new List<int>();
            foreach (var choice in m_choices)
                allChoices.Add(choice.Text);
            foreach(var gotAnswer in a_answers)
            {
                if ( 0 == allChoices.RemoveAll((choice) => 0 == string.Compare(choice, gotAnswer.Item1,StringComparison.InvariantCultureIgnoreCase)))
                    throw new ArgumentException("Die Antworten enthalten eine unbekannte Option", "a_answers");

                if (gotAnswer.Item2)
                {
                    for (int idx = 0; idx < m_choices.Count; idx++)
                    {
                        if (0 == string.Compare(m_choices[idx].Text, gotAnswer.Item1, StringComparison.InvariantCultureIgnoreCase))
                        {
                            choiceIndizes.Add(idx);
                        }
                    }
                }
            }
            if ( allChoices.Count != 0)
                throw new ArgumentException("Die Antworten enthalten nicht alle Optionen", "a_answers");

            var answer = m_answers.Find((a_asw) => a_asw.MatchThisChoices(choiceIndizes));
            if (answer == null)
                throw new ArgumentException("Die Antworten sind nicht in den möglichen Antworten enthalten", "a_answers");

            if (a_solved)
            {
                var solvedAnswer = m_answers.Find( (a_asw) => a_asw.Correct );
                if (solvedAnswer != null)
                {
                    solvedAnswer.Correct = false;
                    solvedAnswer.Checked = false;
                }
            }

            answer.Checked = true;
            answer.Correct = a_solved;
        }

        private void FillAnswers()
        {
            if (NbChoicesNeeded > m_choices.Count)
                throw new ArgumentException("Die Anzahl benötigter Antworten übersteigt die Anzahl der verfügbaren Antworten.");
            if (NbChoicesNeeded < -1)
                throw new ArgumentException("Die Anzahl benötigter Antworten darf nicht kleiner als -1 sein");

            int minNb = NbChoicesNeeded == -1 ? 0 : NbChoicesNeeded;
            int maxNb = NbChoicesNeeded == -1 ? m_choices.Count : NbChoicesNeeded;

            for( int nb = minNb; nb <= maxNb; nb++ )
            {
                if (nb == 0)
                {
                    m_answers.Add(new Answer(new List<int>()));
                }
                else
                {
                    List<int> choiceIndizes = new List<int>();
                    CreateNextAnswers(0, nb - 1, ref choiceIndizes, 0);
                }
            }
        }


        private void CreateNextAnswers( int a_startChoice, int a_nbAdditionalChoices, ref List<int> a_choiceIndizes, int a_choiceIndizesIndex)
        {
            for( int actChoice = a_startChoice; actChoice < m_choices.Count - a_nbAdditionalChoices; actChoice++)
            {
                if (a_choiceIndizes.Count <= a_choiceIndizesIndex)
                    a_choiceIndizes.Add(actChoice);
                else
                    a_choiceIndizes[a_choiceIndizesIndex] = actChoice;

                if (a_nbAdditionalChoices > 0)
                {
                    CreateNextAnswers(actChoice + 1, a_nbAdditionalChoices - 1, ref a_choiceIndizes, a_choiceIndizesIndex + 1);
                }
                else
                {
                    m_answers.Add(new Answer(a_choiceIndizes));
                }
            }
        }

        internal void MergeQuestion(Question otherQuestion)
        {
            if (    (NbChoicesNeeded != otherQuestion.NbChoicesNeeded)
                 || (m_choices.Count != otherQuestion.m_choices.Count) )
                throw new Exception("Die Fragen können nicht zusammengefügt werden.");
            for (int i = 0; i < m_choices.Count; i++)
            {
                if (0 != string.Compare(m_choices[i].Text, otherQuestion.m_choices[i].Text, StringComparison.InvariantCultureIgnoreCase))
                    throw new Exception("Die Fragen können nicht zusammengefügt werden.");
            }

            foreach( var answer in m_answers)
            {
                var otherAnswer = otherQuestion.m_answers.Find((oa) => oa.MatchThisAnswer(answer));
                if (otherAnswer.Correct)
                    answer.Correct = true;
                if (otherAnswer.Checked)
                    answer.Checked = true;
            }
        }


        #region IExtensibleDataObject
        private ExtensionDataObject extensionDataObject_value;
        public ExtensionDataObject ExtensionData
        {
            get
            {
                return extensionDataObject_value;
            }
            set
            {
                extensionDataObject_value = value;
            }
        }
        #endregion

        #region Versionierung
        [DataMember]
        private int m_version;

        [OnSerializing]
        private void OnSerializing(StreamingContext c)
        {
            m_version = 2;
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext c)
        {
            switch(m_version)
            {
                case 1:
                    SortChoicesAndAdjustAnswerIndizes();
                    break;
                default:
                    break;
            }
        }


        private void SortChoicesAndAdjustAnswerIndizes()
        {
            List<string> oldChoicesOrder = new List<string>();
            foreach(var choice in m_choices)
                oldChoicesOrder.Add(choice.Text);
            m_choices.Sort((a, b) => string.Compare(a.Text, b.Text, StringComparison.InvariantCultureIgnoreCase));

            List<Tuple<int, int>> indexmap = new List<Tuple<int, int>>();
            for( int newIdx = 0; newIdx < m_choices.Count; newIdx++ )
            {
                int oldIdx = oldChoicesOrder.FindIndex((str) => 0 == string.Compare(str, m_choices[newIdx].Text, StringComparison.InvariantCultureIgnoreCase));
                if (oldIdx == -1)
                    throw new Exception("Programierfehler!");
                indexmap.Add(new Tuple<int, int>(oldIdx, newIdx));
            }
            foreach (var answer in m_answers)
                answer.AdjustChoiceIndizes(indexmap);
        }

        #endregion
    }
}

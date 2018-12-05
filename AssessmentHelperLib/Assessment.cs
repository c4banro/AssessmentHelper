using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AssessmentHelperLib
{
    [DataContract( Name="Assessment")]
    public class Assessment : IExtensibleDataObject
    {
        [DataMember]
        private List<Question> m_questions = new List<Question>();

        public Assessment()
        {
            Name = "DevOps German";
            /*
            AddQuestion(new Question("Erste Frage", new List<string>() { "Möglichkeit 1", "Möglichkeit 2", "Möglichkeit 3" }, 1));
            AddQuestion(new Question("Zweite Frage", new List<string>() { "Variante 1", "Variante 2", "Variante 3" }, 1));
            */
        }

        [DataMember]
        public string Name { get; private set; }

        public void AddQuestion(Question a_question)
        {
            m_questions.Add(a_question);
        }

        public void DeleteQuestion(string a_question)
        {
            foreach (var question in m_questions)
            {
                if (0 == string.Compare(question.Text, a_question, StringComparison.InvariantCultureIgnoreCase))
                {
                    m_questions.Remove(question);
                    return;
                }
            }
        }

        public List<Question> GetMatchingQuestions(string a_filter)
        {
            List<Question> result = new List<Question>();

            var filterelements = a_filter.Trim().Split(' ');

            foreach(var question in m_questions)
            {
                bool add = true;
                foreach(var element in filterelements)
                {
                    if (-1 == question.Text.IndexOf(element,StringComparison.InvariantCultureIgnoreCase))
                    {
                        add = false;
                        break;
                    }
                }
                if (add)
                    result.Add(question);
            }

            return result;
        }


        public void MergeAssessment( Assessment a_other )
        {
            foreach( var otherQuestion in a_other.m_questions )
            {
                var ownQuestion = m_questions.Find((qst) => 0 == string.Compare(qst.Text, otherQuestion.Text, StringComparison.InvariantCultureIgnoreCase));
                if ( ownQuestion == null )
                {
                    m_questions.Add(otherQuestion);
                }
                else
                {
                    ownQuestion.MergeQuestion(otherQuestion);
                }
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
            m_version = 1;
        }

        [OnDeserialized]
        private void OnDeserialized(StreamingContext c)
        {
        }
        #endregion
    }
}

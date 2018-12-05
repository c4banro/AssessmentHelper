using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AssessmentHelperLib
{
    [DataContract(Name = "Answer")]
    public class Answer : IExtensibleDataObject
    {
        public Answer( List<int> a_choices)
        {
            m_choices = new List<int>(a_choices);
        }

        [DataMember]
        private List<int> m_choices;

        [DataMember]
        public bool Checked { get; set; }

        [DataMember]
        public bool Correct { get; set; }

        public bool ChoiceSet(int a_idx)
        {
            return m_choices.Contains(a_idx);
        }

        public bool MatchThisChoices(List<int> a_choices)
        {
            foreach(int otherChoice in a_choices)
            {
                if (!m_choices.Contains(otherChoice))
                    return false;
            }

            foreach( int ownChoice in m_choices)
            {
                if (!a_choices.Contains(ownChoice))
                    return false;
            }

            return true;
        }

        public bool MatchThisAnswer(Answer a_answer)
        {
            return MatchThisChoices(a_answer.m_choices);
        }


        internal void AdjustChoiceIndizes(List<Tuple<int, int>> indexmap)
        {
            for( int i = 0; i < m_choices.Count; i++)
            {
                var oldIdx = m_choices[i];
                var newIdx = indexmap.Find((entry) => entry.Item1 == oldIdx).Item2;

                m_choices[i] = newIdx;
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

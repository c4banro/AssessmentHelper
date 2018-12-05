using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace AssessmentHelperLib
{
    [DataContract(Name = "Choice")]
    public class Choice : IExtensibleDataObject
    {
        public Choice( string a_choice)
        {
            Text = a_choice;
        }


        [DataMember]
        public string Text { get; private set; }

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

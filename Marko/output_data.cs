using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace Marko
{
    [DataContract]
    class output_data
    {
        [DataMember]
        internal string query;

        [DataMember]
        internal string uid;

        [DataMember]
        internal string reset;
    }
}

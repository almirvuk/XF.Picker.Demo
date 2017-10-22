using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XF.Picker.Demo.Models {

    public class Person {

        public int PersonId { get; set; }

        public string FName { get; set; }
        public string LName { get; set; }

        public string FullName { get { return $"{FName} {LName}"; } }
        public string Biography { get; set; }

    }
}

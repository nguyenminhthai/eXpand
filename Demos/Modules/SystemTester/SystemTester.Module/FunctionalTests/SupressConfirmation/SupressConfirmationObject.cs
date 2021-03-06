﻿using DevExpress.Persistent.Base;
using DevExpress.Persistent.BaseImpl;
using DevExpress.Xpo;

namespace SystemTester.Module.FunctionalTests.SupressConfirmation {
    [DefaultClassOptions]
    public class SupressConfirmationObject:BaseObject {
        public SupressConfirmationObject(Session session) : base(session){
            
        }

        string _name;

        public string Name{
            get { return _name; }
            set { SetPropertyValue(nameof(Name), ref _name, value); }
        }    
    }

}

﻿using System;
using DevExpress.ExpressApp;
using DevExpress.ExpressApp.DC;
using eXpand.ExpressApp.Logic.Model;

namespace eXpand.ExpressApp.Logic
{
    public abstract class LogicRule : ILogicRule 
    {
        readonly ILogicRule _logicRule;

        protected LogicRule(ILogicRule logicRule){
            _logicRule = logicRule;
        }

        public string ID {
            get { return _logicRule.Id; }
            set { _logicRule.Id = value; }
        }

        public string ExecutionContextGroup {
            get { return _logicRule.ExecutionContextGroup; }
            set { _logicRule.ExecutionContextGroup = value; }
        }

        public IModelExecutionContext ContextGroup
        {
            get { throw new NotImplementedException(); }
            set { throw new NotImplementedException(); }
        }

        public ViewType ViewType {
            get { return _logicRule.ViewType; }
            set { _logicRule.ViewType = value; }
        }

        public Nesting Nesting {
            get { return _logicRule.Nesting; }
            set { _logicRule.Nesting = value; }
        }


        string IRule.Id {
            get { return ID; }
            set { ID=value; }
        }

        public string Description {
            get { return _logicRule.Description; }
            set { _logicRule.Description = value; }
        }

        public ITypeInfo TypeInfo {
            get { return _logicRule.TypeInfo; }
            set { _logicRule.TypeInfo = value; }
        }

        public string ViewId {
            get { return _logicRule.ViewId; }
            set { _logicRule.ViewId = value; }
        }
        public int Index
        {
            get { return _logicRule.Index; }
            set { _logicRule.Index = value; }
        }

//        public IModelClass ModelClass { get; set; }
    }
}



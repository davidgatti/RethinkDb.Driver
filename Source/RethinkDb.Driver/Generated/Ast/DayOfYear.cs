








//AUTOGENERATED, DO NOTMODIFY.
//Do not edit this file directly.

#pragma warning disable 1591
// ReSharper disable CheckNamespace

using System;
using RethinkDb.Driver.Ast;
using RethinkDb.Driver.Model;
using RethinkDb.Driver.Proto;
using System.Collections.Generic;


namespace RethinkDb.Driver.Ast {
    public class DayOfYear : ReqlExpr {

    
    
    
        public DayOfYear (object arg) : this(new Arguments(arg), null) {
        }
        public DayOfYear (Arguments args) : this(args, null) {
        }
        public DayOfYear (Arguments args, OptArgs optargs)
             : this(TermType.DAY_OF_YEAR, args, optargs) {
        }

    protected DayOfYear (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}

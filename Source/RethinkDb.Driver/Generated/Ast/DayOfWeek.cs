








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
    public class DayOfWeek : ReqlExpr {

    
    
    
        public DayOfWeek (object arg) : this(new Arguments(arg), null) {
        }
        public DayOfWeek (Arguments args) : this(args, null) {
        }
        public DayOfWeek (Arguments args, OptArgs optargs)
             : this(TermType.DAY_OF_WEEK, args, optargs) {
        }

    protected DayOfWeek (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}

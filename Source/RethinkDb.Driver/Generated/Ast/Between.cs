








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
    public class Between : ReqlExpr {

    
    
    
        public Between (object arg) : this(new Arguments(arg), null) {
        }
        public Between (Arguments args) : this(args, null) {
        }
        public Between (Arguments args, OptArgs optargs)
             : this(TermType.BETWEEN, args, optargs) {
        }

    protected Between (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}

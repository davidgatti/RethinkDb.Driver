








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
    public class Add : ReqlExpr {

    
    
    
        public Add (object arg) : this(new Arguments(arg), null) {
        }
        public Add (Arguments args) : this(args, null) {
        }
        public Add (Arguments args, OptArgs optargs)
             : this(TermType.ADD, args, optargs) {
        }

    protected Add (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}

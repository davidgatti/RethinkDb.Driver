








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
    public class SpliceAt : ReqlExpr {

    
    
    
        public SpliceAt (object arg) : this(new Arguments(arg), null) {
        }
        public SpliceAt (Arguments args) : this(args, null) {
        }
        public SpliceAt (Arguments args, OptArgs optargs)
             : this(TermType.SPLICE_AT, args, optargs) {
        }

    protected SpliceAt (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}










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
    public class IndexStatus : ReqlExpr {

    
    
    
        public IndexStatus (object arg) : this(new Arguments(arg), null) {
        }
        public IndexStatus (Arguments args) : this(args, null) {
        }
        public IndexStatus (Arguments args, OptArgs optargs)
             : this(TermType.INDEX_STATUS, args, optargs) {
        }

    protected IndexStatus (TermType termType, Arguments args, OptArgs optargs) : base(termType, args, optargs)
    {
    }


    



    

    


    
    }
}

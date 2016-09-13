﻿namespace Simple1C.Impl.Sql.SqlAccess.Syntax
{
    internal class SelectField : ISqlElement
    {
        public ISqlElement Expression { get; set; }
        public string Alias { get; set; }

        public ISqlElement Accept(SqlVisitor visitor)
        {
            return visitor.VisitSelectField(this);
        }
    }
}
#region COPYRIGHT
//
//     THIS IS GENERATED BY TEMPLATE
//     
//     AUTHOR  :     ROYE
//     DATE       :     2010
//
//     COPYRIGHT (C) 2010, TIANXIAHOTEL TECHNOLOGIES CO., LTD. ALL RIGHTS RESERVED.
//
#endregion

using System;
using System.Collections.Generic;
using System.Text;

namespace System.Text.Template
{
    public class UnaryMinusExpression : Expression
    {
        private readonly Expression _value;

        public UnaryMinusExpression(Expression value)
        {
            _value = value;
        }

        public override ValueExpression Evaluate(ITemplateContext context)
        {
            ValueExpression value = _value.Evaluate(context);

            if (value.Type == typeof(decimal))
                return Expression.Value(-(decimal)value.Value);

            if (value.Type == typeof(double))
                return Expression.Value(-(double)value.Value);

            if (value.Type == typeof(float))
                return Expression.Value(-(float)value.Value);

            if (value.Type == typeof(uint))
                return Expression.Value(-(uint)value.Value);

            if (value.Type == typeof(int))
                return Expression.Value(-(int)value.Value);

            if (value.Type == typeof(long))
                return Expression.Value(-(long)value.Value);

            throw new OverflowException();
        }
    }
}

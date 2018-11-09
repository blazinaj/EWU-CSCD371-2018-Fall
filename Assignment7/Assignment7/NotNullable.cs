using System;

namespace Assignment7s
{
    /*
     *  NotNullable is a generic reference type.
     *  When insantiating NotNullable, one may declare the Type.
     *  NotNullable has a Type T "Value" property
     *  
     *  Structs are value types and are thus excluded in general.
     *  
     *  In order to have the Value property be not nullable, we 
     *  could potentially constrain it with where T : new(), 
     *  that would prevent classes without default value constructors 
     *  to be used. With an explicit value constructor, we could
     *  always pass the value through null checks.
     *  The caveat is the compiler then won't let you pass in 
     *  things like Strings as a generic, as they don't pass the constraint.
     *  
     *  If we don't use constraints, then we could set the type to be
     *  whatever we wanted. If the Type is an int or other value type,
     *  it would then not be nullable. The caveat is that then we would 
     *  have to take in Strings and other reference types, and we have 
     *  no way to guard against it being explicity set to null.
     * 
     */
    public class NotNullable<T>
        where T : new()
    {
        public NotNullable()
        {
            Value = default(T);
        }

        public NotNullable(T e)
        {
            Value = e;
        }

        private T _value;
        public T Value
        {
            get { return _value; }
            set
            {
                if (value == null)
                {
                    _value = default(T);
                }
                else
                {
                    _value = value;
                }
            }
        }

    }
}
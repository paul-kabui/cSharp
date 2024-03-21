/*
    private    -> only accesssible to the class only
    Public     -> accessible to the consumer
    protected  -> keyword marks field, methods properties and nested classes for use inside the same class and
                  derived classes only:
    internal   -> class (including nested classes), property, method or field available to every
                  consumer in the same assembly
    protected internal ->
    marks field, methods, properties and nested classes for use inside the same
    assembly or derived classes in another assembly
 */

namespace ASPSTORE.OopsConcept
{
    public class Student(string Name, string Id, string Course)
    {
        protected internal string Name { get; set; } = Name;
        protected internal string Id { get; set; } = Id;
        protected internal string Course { get; set; } = Course;
    }
}
using AutoMapper;
using System;

namespace MyApp.Common
{
    public class NoSpaces : ITypeConverter<string, string>
    {
        public string Convert(string source, string destination, ResolutionContext context)
        {
            if (source != null)
            {
                if (!(String.IsNullOrEmpty(source.ToString())))
                {
                    return source.ToString().Replace(" ", "");
                }
            }
            return string.Empty;
        }
    }
}
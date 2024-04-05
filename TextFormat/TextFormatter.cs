using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextFormat.Interfaces;

namespace TextFormat
{
    public abstract class TextDecorator : ITextComponent
    {
        protected ITextComponent _textComponent;

        public TextDecorator(ITextComponent textComponent)
        {
            _textComponent = textComponent;
        }

        public virtual string ApplyFormatting()
        {
            return _textComponent.ApplyFormatting();
        }

        public virtual string RemoveFormat()
        {
            return _textComponent.ApplyFormatting();
        }
    }
}

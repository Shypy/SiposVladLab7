using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Maui.Controls; // Asigură-te că acest namespace este prezent

namespace SiposVladLab7
{
    public class ValidationBehaviour : Behavior<Editor>
    {
        protected override void OnAttachedTo(Editor entry)
        {
            entry.TextChanged += OnEntryTextChanged;
            base.OnAttachedTo(entry);
        }

        protected override void OnDetachingFrom(Editor entry)
        {
            entry.TextChanged -= OnEntryTextChanged;
            base.OnDetachingFrom(entry);
        }

        void OnEntryTextChanged(object sender, TextChangedEventArgs args)
        {
            var editor = (Editor)sender;

            // Verifică dacă textul este gol și aplică culoarea de fundal corespunzătoare
            editor.BackgroundColor = string.IsNullOrEmpty(args.NewTextValue)
                ? Colors.Red // Culoare de fundal roșie dacă textul lipsește
                : Colors.White; // Fundal alb dacă textul este introdus
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
1. pytanie ilu graczy - połączyć z formsem 
2. losuje 8 kart dla kazdej osoby
3. jezeli w tych wylosowanych kartach będą pary usuwam
4. sprawdzam czy kązdy ma conajmniej 1 karte na reku
5. jezeli ktos ma 0 kart wpisuje do tabeli jako 1 miejsce i ta osoba nie gra
6. jezeli nie kontynuuje
7. gramy tak długo dopoki 1 osoba będzie miała 1 kartep iotrusia (bool?)
8. wyświetlam tabele z wynikami 
9. moze eksport do csv?
 */
namespace karcioszki
{
   
    public partial class PIOTRUS : Form
    {
        liczba_os uczestnicy;
        public PIOTRUS(liczba_os uczestnicy)
        {
            InitializeComponent();
            this.uczestnicy = uczestnicy;
        }


    }
}

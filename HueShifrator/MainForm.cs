/*
By InnieSharp(ix4/i#)
*/
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Linq;

namespace HueShifrator
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		Dictionary<char, char> chars = new Dictionary<char, char>
		{
			{ 'q', 'Å' },
			{ 'w', 'Á' },
			{ 'e', 'Ð' },
			{ 'r', 'ã' },
			{ 't', 'ñ' },
			{ 'y', 'Ü' },
			{ 'u', '¼' },
			{ 'i', 'ß' },
			{ 'o', '÷' },
			{ 'p', 'ú' },
			{ 'a', 'þ' },
			{ 's', 'Ø' },
			{ 'd', 'µ' },
			{ 'f', '¥' },
			{ 'g', 'Ï' },
			{ 'h', 'ð' },
			{ 'j', 'ÿ' },
			{ 'k', '▢' },
			{ 'l', '◮' },
			{ 'z', '▰' },
			{ 'x', '◯' },
			{ 'c', '◹' },
			{ 'v', '◘' },
			{ 'b', '▙' },
			{ 'n', '✠' },
			{ 'm', '☰' },
			{ 'Q', '☑' },
			{ 'W', '☈' },
			{ 'E', '★' },
			{ 'R', '☢' },
			{ 'T', '❆' },
			{ 'Y', '✡' },
			{ 'U', '❤' },
			{ 'I', '✂' },
			{ 'O', '✇' },
			{ 'P', '➱' },
			{ 'A', '❐' },
			{ 'S', '❖' },
			{ 'D', '⑰' },
			{ 'F', '⑫' },
			{ 'G', '⑦' },
			{ 'H', '⓿' },
			{ 'J', '❻' },
			{ 'K', '▅' },
			{ 'L', '░' },
			{ 'Z', '╳' },
			{ 'X', '╪' },
			{ 'C', '┆' },
			{ 'V', '┈' },
			{ 'B', 'ᴂ' },
			{ 'N', 'ῲ' },
			{ 'M', 'ᶈ' },
			{ ',', 'ᴖ' },
			{ '.', 'ᴗ' },
			{ '!', 'ᴙ' },
			{ '?', 'ᴞ' },
			{ 'й', 'ℂ'},
			{ 'ц', 'ℋ'},
			{ 'у', '℈'},
			{ 'к', 'ℍ'},
			{ 'е', 'ℐ'},
			{ 'н', '℔'},
			{ 'г', '℗'},
			{ 'ш', 'ℙ'},
			{ 'щ', 'ℛ'},
			{ 'з', '℠'},
			{ 'х', '℡'},
			{ 'ъ', '℣'},
			{ 'ф', '℥'},
			{ 'ы', 'Ω'},
			{ 'в', '℧'},
			{ 'а', '℩'},
			{ 'п', 'ℬ'},
			{ 'р', 'ℱ'},
			{ 'о', '℻'},
			{ 'л', '⅓'},
			{ 'д', '⅔'},
			{ 'ж', '⅕'},
			{ 'э', '⅖'},
			{ 'я', '⅗'},
			{ 'ч', 'ℽ'},
			{ 'с', '⅀'},
			{ 'м', '⅁'},
			{ 'и', '⅂'},
			{ 'т', '⅄'},
			{ 'ь', 'ⅇ'},
			{ 'б', '⅊'},
			{ 'ю', '⅋'},
			{ 'Й', '⅍'},
			{ 'Ц', 'ⅎ'},
			{ 'У', '∀'},
			{ 'К', '∄'},
			{ 'Е', '∉'},
			{ 'Н', '∎'},
			{ 'Г', '∐'},
			{ 'Ш', '∓'},
			{ 'Щ', '√'},
			{ 'З', '∜'},
			{ 'Х', '∞'},
			{ 'Ъ', '∠'},
			{ 'Ф', '∢'},
			{ 'Ы', '∤'},
			{ 'В', '∬'},
			{ 'А', '∰'},
			{ 'П', '∴'},
			{ 'Р', '∹'},
			{ 'О', '∾'},
			{ 'Л', '≅'},
			{ 'Д', '≈'},
			{ 'Ж', '≊'},
			{ 'Э', '≔'},
			{ 'Я', '≝'},
			{ 'Ч', '≠'},
			{ 'С', '≨'},
			{ 'М', '≫'},
			{ 'И', '≪'},
			{ 'Т', '≭'},
			{ 'Ь', '≲'},
			{ 'Б', '≸'},
			{ 'Ю', '≽'},
			{ '-', '⋢'},
			{ '=', '⋥'},
			{ '+', '⋪'},
			{ '_', '⋮'},
			{ '0', '⋳'},
			{ '1', '⌘'},
			{ '2', '⌗'},
			{ '3', '⋈'},
			{ '4', '⇵'},
			{ '5', '⇱'},
			{ '6', '⊶'},
			{ '7', '⌇'},
			{ '8', '⌧'},
			{ '9', '♡'},
			{ '#', '⋰'},
		};
		
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		void Button1Click(object sender, EventArgs e)
		{
			string next = "";
			foreach(char c in richTextBox1.Text)
			{
				if(chars.ContainsKey(c))
					next += chars[c].ToString();
				else
					next += c.ToString();
			}
			richTextBox1.Text = next;
			// var myKey = types.FirstOrDefault(x => x.Value == "one").Key;
		}
		void Button2Click(object sender, EventArgs e)
		{
			string next = "";
			foreach(char c in richTextBox1.Text)
			{
				if(chars.ContainsValue(c))
				{
					var myKey = chars.FirstOrDefault(x => x.Value == c).Key;
					next += myKey.ToString();
				}
				else
					next += c.ToString();
			}
			richTextBox1.Text = next;
		}
	}
}

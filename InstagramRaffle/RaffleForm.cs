using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace InstagramRaffle
{
  public partial class RaffleForm : Form
  {
    public RaffleForm()
    {
      InitializeComponent();
    }

    private void AyiklaVeSiralaClick(object sender, EventArgs e)
    {
      string pattern = @"^([^'\r\n]*)'.*\r\n\1\r\n(.*)\r\n.*\r\n";
      RegexOptions options = RegexOptions.Multiline;

      AyiklananText.Clear();

      foreach (Match m in Regex.Matches(AyiklanacakText.Text, pattern, options))
      {
        foreach (var etiket in m.Groups[2].Value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries))
        {
          if (etiket.StartsWith("@"))
          {
            AyiklananText.AppendText(m.Groups[1].Value + "\t" + etiket + "\r\n");
          }
        }
      }

      var sirali = AyiklananText.Lines.OrderBy(r => r).Distinct();

      AyiklananText.Clear();
      foreach (var k in sirali)
      {
        if (Regex.IsMatch(k, @"^([^\t]*)\t(.*)"))
        {
          AyiklananText.AppendText(k + "\r\n");
        }
      }
    }

    private void IstatistikClick(object sender, EventArgs e)
    {

      var katilimci = new Dictionary<string, int>();
      var etiketlenen = new Dictionary<string, int>();

      string pattern = @"^([^\t]*)\t(.*)";
      RegexOptions options = RegexOptions.Multiline;


      foreach (Match m in Regex.Matches(AyiklananText.Text, pattern, options))
      {
        if (katilimci.ContainsKey(m.Groups[1].Value))
        {
          katilimci[m.Groups[1].Value]++;
        }
        else
        {
          katilimci[m.Groups[1].Value] = 1;
        }
        if (etiketlenen.ContainsKey(m.Groups[2].Value))
        {
          etiketlenen[m.Groups[2].Value]++;
        }
        else
        {
          etiketlenen[m.Groups[2].Value] = 1;
        }
      }

      IstatistikText.Text = $"Çekilişe Katılan:\r\n{katilimci.Count}\r\n\r\nToplam Etiketlenen:\r\n{etiketlenen.Count}\r\n";

    }

    private void CekilisClick(object sender, EventArgs e)
    {
      var rnd = new Random();

      var karma = AyiklananText.Lines.Where(k => Regex.IsMatch(k, @"^([^\t]*)\t(.*)")).Select(t => t.Split('\t')[0]).OrderBy(r => rnd.Next()).Distinct().ToArray();

      var kazananlar = karma.Take(10).ToArray();

      for (int i = 0; i < kazananlar.Length; i++)
      {
        KazananlarText.AppendText($"{i + 1:00}. {kazananlar[i]}\r\n");
      }
      var yedekler = karma.Skip(10).Take(10).ToArray();
      for (int i = 0; i < yedekler.Length; i++)
      {
        YedeklerText.AppendText($"{i + 1:00}. {yedekler[i]}\r\n");
      }
    }

    private void TemizleClick(object sender, EventArgs e)
    {
      AyiklanacakText.Clear();
      AyiklananText.Clear();
      IstatistikText.Clear();
      KazananlarText.Clear();
      YedeklerText.Clear();

    }
  }
}

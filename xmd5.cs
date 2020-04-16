using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace DataMan
{



    //private string sha1pattern = @"\b[A-Fa-f0-9]{40}\b";
    //private string sha256pattern = @"\b[A-Fa-f0-9]{64}\b";

    class xmd5
    {
        //public string Rtb1text { get; set; }

        //Regex md5regex = new Regex(@"\b[A-Fa-f0-9]{32}\b");
        //MatchCollection md5collection = md5regex.Matches(richTextBox9.Text);
        Regex md5regex = new Regex(@"\b[A-Fa-f0-9]{32}\b");
        TextRange textRangeinput = new TextRange(rtb1maininput.Document.ContentStart, rtb1maininput.Document.ContentEnd);
        MatchCollection md5collection = md5regex.Matches(textRangeinput.Text);
            foreach (Match md5match in md5collection) 
            {
                rtb2results.AppendText(md5match.Value + Environment.NewLine);
            }

}
}

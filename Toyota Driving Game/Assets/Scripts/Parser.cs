using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Parser : MonoBehaviour { }
 /*   Scanner oScan;
	// Use this for initialization
	void Start () {
        oScan = new Scanner(new File("20170303_ms.csv"));
        oScan.nextLine();//skip name line
    }
	
	// Update is called once per frame
	void Update () {
        String sLine = oScan.nextLine();
        double[] vals = foo.Split(' ').Select(p => double.Parse(p)).ToArray();
        Debug.log(Arrays.toString(vals));
    }
}

class Scanner : System.IO.StringReader
{
    string currentWord;

    public Scanner(string source) : base(source)
    {
        readNextWord();
    }

    private void readNextWord()
    {
        System.Text.StringBuilder sb = new StringBuilder();
        char nextChar;
        int next;
        do
        {
            next = this.Read();
            if (next < 0)
                break;
            nextChar = (char)next;
            if (char.IsWhiteSpace(nextChar))
                break;
            sb.Append(nextChar);
        } while (true);
        while ((this.Peek() >= 0) && (char.IsWhiteSpace((char)this.Peek())))
            this.Read();
        if (sb.Length > 0)
            currentWord = sb.ToString();
        else
            currentWord = null;
    }

    public bool hasNextInt()
    {
        if (currentWord == null)
            return false;
        int dummy;
        return int.TryParse(currentWord, out dummy);
    }

    public int nextInt()
    {
        try
        {
            return int.Parse(currentWord);
        }
        finally
        {
            readNextWord();
        }
    }

    public bool hasNextDouble()
    {
        if (currentWord == null)
            return false;
        double dummy;
        return double.TryParse(currentWord, out dummy);
    }

    public double nextDouble()
    {
        try
        {
            return double.Parse(currentWord);
        }
        finally
        {
            readNextWord();
        }
    }

    public bool hasNext()
    {
        return currentWord != null;
    }
}*/
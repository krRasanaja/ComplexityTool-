using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ComplexityTool.Size
{
    class SizeComplexity
    {
   
        public int operatorsScore(String code)
        {
            int flag = 0;
            int score = 0;
            int iteration = 0;
            int extendCount = 0;
            String str = code;
            //split code into words separated by spaces
            String[] words = str.Split(' ');
          
            //create a array with all characters in the code
            char[] charArray = new char[str.Length];
            charArray = str.ToCharArray();

 
            try
            {
                //loop characters in the charArray
                foreach (char ch in charArray)
                {
                    //check for "." and ","
                    if (Regex.IsMatch(ch.ToString(), @"^[,.]"))
                    {
                        score = score + 1;
                    }

                }

                //loop the word by word in the code
                foreach (String word in words)
                {
                    //check for double quotes and skip
                    if(Regex.Matches(word, "\"").Count == 2)
                    {
                        flag = 0;
                        continue;
                    }

                    if (Regex.Matches(word, "\"").Count == 1) //check start of a double quote
                    {
                        flag = 1;
                        
                    }

                    if ((flag == 1) && Regex.Matches(word, "\"").Count == 1) //check end of a double quote
                    {
                        flag = 0;
                        continue;
                    }
                    else if(flag == 0) //executes following if word is not within double quotes
                    {

                        string[] singleOperators = new string[] { "+", "-", "*", "/", "%", ">", "<", "!", "|", "^", "~", "=" };

                        string[] otherOperators = new string[] { "++", "--", "==", "<<", ">>", "!=", ">=", "<=", "&&", "||", "->", "::", "+=", "-=", "*=", "/=", ">>>=", "|=", "&=", "%=", "<<=", ">>=", "^=", ">>>", "<<<" };

                        if (otherOperators.Any(word.Contains))
                        {
                            score = score + 1;
                        }
                        else if (singleOperators.Any(word.Contains))
                        {
                            score = score + 1;
                        }

                        if (word.Contains("//"))
                        {
                            score = score - 1;
                        }
                    }
                }

                foreach(string word in words)
                {
                    ExtendedProperties extendedProperties = new ExtendedProperties();

                    if(words.Length>3)
                    {
                        if (word.ToLower().Equals("class"))
                        {
                            extendedProperties.ClassName = words[iteration + 1];

                            if (words[iteration + 2].Equals(":"))
                            {
                                string temp = words[iteration + 3];

                                int rowEC = GlobalData.list.Find(x => x.ClassName.Equals(words[iteration + 3])).Vaue + 1;
                                extendCount = rowEC + extendCount;

                                if (!GlobalData.list.Any(x => x.ClassName.ToLower().Equals(words[iteration + 1].ToLower())))
                                {
                                    extendedProperties.Vaue = rowEC;
                                    GlobalData.list.Add(extendedProperties);
                                }
                                else
                                {
                                    GlobalData.list.Where(x => x.ClassName.ToLower().Equals(word.ToLower())).ToList().ForEach(x => x.Vaue = extendCount);
                                }

                                GlobalData.isExtendedRow = true;
                            }

                        }
                        else if (word.ToLower().Equals("class"))
                        {
                            if (!GlobalData.list.Any(x => x.ClassName.ToLower().Equals(word.ToLower())))
                            {
                                extendedProperties.Vaue = 2;
                                extendedProperties.ClassName = words[iteration+1];
                                GlobalData.list.Add(extendedProperties);
                            }

                        }
                    }
                    else if(word.ToLower().Equals("class"))
                    {
                        if (!GlobalData.list.Any(x => x.ClassName.ToLower().Equals(word.ToLower())))
                        {
                            extendCount = 2;
                            extendedProperties.Vaue = 2;
                            extendedProperties.ClassName = words[iteration+1];
                            GlobalData.list.Add(extendedProperties);
                            GlobalData.isExtendedRow = true;
                        }

                    }
                    iteration++;
                }
                GlobalData.ExtendCount = GlobalData.ExtendCount + extendCount;
                extendCount = 0;
                iteration = 0;
            }
            catch(Exception ex)
            {
                throw ex;
            }

            return score;
        }
    }
}

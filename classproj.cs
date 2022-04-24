using System;
using System.Collections.Generic;



namespace Recount
{
class Program
{
static void Main(string[] args)
{
Dictionary<string, int> candidates = new Dictionary<string, int>();
List<int> nameList = new List<int>();
string winnter = "";
while (true)
{
string name = Console.ReadLine();
if (name == "***")
{
break;
}
addOrUpdate(candidates, name, 1);
}
foreach (KeyValuePair<string, int> element in candidates)
{
nameList.Add(element.Value);
}
int maxNameList = maxValue(nameList);
int i = 0;
foreach (int value in nameList)
{
if (value == maxNameList)
{
i++;
}
}
if (i == 1)
{
foreach(KeyValuePair<string, int> element in candidates)
{
if (element.Value == maxNameList)
{
winner = element.Key;
break;
}
}
Console.WriteLine(winner);
}
else
{
Console.WriteLine("Runoff!");
}

}
static void addOrUpdate(Dictionary<string, int> dict, string key, int value)
{
if (dict.ContainsKey(key))
{
dict[key] += value;
}
else
{
dict.Add(key, value);
}
}

static int maxValue(List<int> numList)
{
int max = numList[0];
for (int index = 1; index < numList.Count; index++)
{
if(numList[index] > max)
{
max = numList[index];
}
}
return max;
}
}
}

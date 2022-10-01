// See https://aka.ms/new-console-template for more information
void rec(string s2, string c)
{
string s1;
int i;
if (s2.Length == 0)
Console.WriteLine(c);
else
{
for (i = 0; i < s2.Length; i++)
{
c += s2[i];
s1 = s2;
s1 = s1.Remove(i, 1);
rec(s1, c);
c = c.Remove(c.Length - 1, 1);
}
}
}


int i;
string? s, c, s2;
s = Console.ReadLine();
for(i = 0; i < s.Length; i++)
{
c = Convert.ToString(s[i]);
s2 = Convert.ToString(s);
s2 = s2.Remove(i, 1);
rec(s2, c);
}

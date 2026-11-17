using System;
using System.Collections.Generic;
using System.Security.Policy;
using System.Threading;
using System.Xml.Linq;

namespace GeneralTreeExample
{
    public class TreeNode<T>
    {
        public T Value { get; set; }
        public List<TreeNode<T>> Children { get; set; }

        public TreeNode(T value)
        {
            this.Value = value;
            Children = new List<TreeNode<T>>();
        }

        public void AddChild(TreeNode<T> child)
        {
            Children.Add(child);
        }
    }

    public class Tree<T>
    {
        public TreeNode<T> Root { get; private set; }
        //After initialization, the Root property cannot be changed from outside the class.
        //This ensures that the tree always has a valid root node and prevents accidental or malicious modifications.
        //The private set ensures that the Root property can only be modified within the Tree<T> class.
        public Tree(T rootValue)
        {
            Root = new TreeNode<T>(rootValue);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Creating the tree
            var CompanyTree = new Tree<string>("CEO");
            var Finance = new TreeNode<string>("CFO");
            var Tech = new TreeNode<string>("CTO");
            var Marketing = new TreeNode<string>("CMO");

            // Adding departments to the CEO node
            CompanyTree.Root.AddChild(Finance);
            CompanyTree.Root.AddChild(Tech);
            CompanyTree.Root.AddChild(Marketing);

            // Adding employees to departments
            Finance.AddChild(new TreeNode<string>("Accountant"));
            Tech.AddChild(new TreeNode<string>("Developer"));
            Tech.AddChild(new TreeNode<string>("UX Designer"));
            Marketing.AddChild(new TreeNode<string>("Social Media Manager"));

            // Printing the tree
            PrintTree(CompanyTree.Root);
            Console.ReadKey();

        }

        public static void PrintTree<T>(TreeNode<T> node, string indent = " ")
        {
            int IndentLen = indent.Length;
            Console.WriteLine(indent + node.Value);
            foreach (var child in node.Children)
            {
                PrintTree(child, indent + "  ");
            }
            // (CEO , " ")                         Output CEO
            // Func1: (CFO , "   ")                Output   CFO
            // Func2: (Accountant , "     ")       Output     Accountant

            //  resets to three spaces when the recursion returns to a previous level.

            // Func3: (CTO , "   ")                Output   CTO
            // Func4: (Developer ,  "     ")       Output     Developer
            // Func5: (UX Designer ,"     ")       Output     UX Designer

            // resets to three spaces when the recursion returns to a previous level.

            // Func6: (CMO , "   ")                Output   CMO
            // Func7: (Social Media Manager ,"     ") Output     Social Media Manager
        }
    }
}

//Key Concept: Recursion and Indentation
//When you call PrintTree recursively, the indent string grows by adding " " (two spaces) for each level of depth in the tree. However, when the recursion returns to a previous level (e.g., when moving from a child node back to its parent or sibling), the indent string resets to the value it had at that level.

//This is because the indent string is passed by value in each recursive call. Each call to PrintTree gets its own copy of the indent string, and changes to it (like appending " ") do not affect the indent string in the caller.

//Step-by-Step Explanation:
//Let’s revisit the example and focus on how the indent string changes:

//Initial Call:
//csharp
//Copy
//PrintTree(CompanyTree.Root, " ");
//node.Value is "CEO".

//indent is " "(one space).

//Output: " CEO".

//Recursive Call 1 (CFO):
//csharp
//Copy
//PrintTree(Finance, "   ");
//node.Value is "CFO".

//indent is " "(three spaces, because " " + " ").

//Output: " CFO".

//Recursive Call 2 (Accountant):
//csharp
//Copy
//PrintTree(Accountant, "     ");
//node.Value is "Accountant".

//indent is " "(five spaces, because " " + " ").

//Output: " Accountant".

//Return to CFO Level:
//After printing "Accountant", the recursion returns to the CFO level.

//At this point, the indent string is still " " (three spaces), as it was when PrintTree(Finance, " ") was called.

//Recursive Call 3 (CTO):
//csharp
//Copy
//PrintTree(Tech, "   ");
//node.Value is "CTO".

//indent is " "(three spaces, because " " + " ").

//Output: " CTO".

//Recursive Call 4 (Developer):
//csharp
//Copy
//PrintTree(Developer, "     ");
//node.Value is "Developer".

//indent is " "(five spaces, because " " + " ").

//Output: " Developer".

//Recursive Call 5 (UX Designer):
//csharp
//Copy
//PrintTree(UXDesigner, "     ");
//node.Value is "UX Designer".

//indent is " "(five spaces, because " " + " ").

//Output: " UX Designer".

//Return to CTO Level:
//After printing "UX Designer", the recursion returns to the CTO level.

//At this point, the indent string is still " " (three spaces), as it was when PrintTree(Tech, " ") was called.

//Recursive Call 6 (CMO):
//csharp
//Copy
//PrintTree(Marketing, "   ");
//node.Value is "CMO".

//indent is " "(three spaces, because " " + " ").

//Output: " CMO".

//Recursive Call 7 (Social Media Manager):
//csharp
//Copy
//PrintTree(SocialMediaManager, "     ");
//node.Value is "Social Media Manager".

//indent is " "(five spaces, because " " + " ").

//Output: " Social Media Manager".

//Why Does the Indent "Reset"?
//The indent string does not actually reduce from five spaces to three spaces. Instead, it resets to three spaces when the recursion returns to a previous level. This happens because:

//Each recursive call gets its own copy of the indent string.

//When the recursion returns to a previous level, the indent string reverts to the value it had at that level.

//For example:

//When PrintTree(Finance, " ") is called, the indent is " ".

//When PrintTree(Accountant, " ") is called, the indent becomes " ".

//After printing "Accountant", the recursion returns to the CFO level, where the indent is still " ".

//Visual Representation of Indent Changes:
//Recursive Call	Node Value	Indent String	Explanation
//Initial Call	CEO	" "	Starts with one space.
//Func1	CFO	" "	" " + " " → Three spaces.
//Func2	Accountant	" "	" " + " " → Five spaces.
//Return to CFO	-	" "	Returns to CFO level, where indent is still " ".
//Func3	CTO	" "	" " + " " → Three spaces (resets to sibling level).
//Func4	Developer	" "	" " + " " → Five spaces.
//Func5	UX Designer	" "	" " + " " → Five spaces.
//Return to CTO	-	" "	Returns to CTO level, where indent is still " ".
//Func6	CMO	" "	" " + " " → Three spaces (resets to sibling level).
//Func7	Social Media Manager	" "	" " + " " → Five spaces.
//Final Output:
//The output of the program will look like this:

//Copy
// CEO
//   CFO
//     Accountant
//   CTO
//     Developer
//     UX Designer
//   CMO
//     Social Media Manager
//Summary:
//The indent string does not reduce from five spaces to three spaces. Instead, it resets to three spaces when the recursion returns to a previous level.

//This happens because each recursive call gets its own copy of the indent string, and changes to it do not affect the caller's indent string.

//The indentation grows as you go deeper into the tree and resets when you move back up to a sibling or parent node.

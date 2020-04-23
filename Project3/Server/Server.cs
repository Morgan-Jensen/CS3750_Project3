using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project3.Server
{
	public static class Server
	{
		public static int GroupCount = 3;

		public static void IncreaseCount()
		{
			GroupCount++;
		}

		public static int GetGroupCount()
		{
			return GroupCount;
		}
	}
}


// Old code we probably wont need but here it is just in case

//	/// <summary>
//	/// Collection of groups.
//	/// </summary>
//	private static ArrayList Groups;

//	/// <summary>
//	/// Main method for handling groups to client.
//	/// </summary>
//	/// <param name="content">string from client about groups and pages</param>
//	/// <returns>string to client about groups and pages</returns>
//	public static string ManageGroups(string content)
//	{
//		Groups = new ArrayList();
//		string[] groups = content.Split(';');

//		foreach (string group in groups)
//		{
//			string[] words = group.Split(',');

//			Group newGroup = new Group(words[0]);

//			foreach (string word in words)
//			{
//				newGroup.AddMember(word);
//			}

//			Groups.Add(newGroup);
//		}

//		return GenerateReturnString(Groups);
//	}


//	/// <summary>
//	/// Generates a string to return to client
//	/// </summary>
//	/// <param name="groups">Collection of Groups</param>
//	/// <returns>Looks like: title,page,page;title,page,page,page;</returns>
//	public static string GenerateReturnString(ArrayList groups)
//	{
//		string returnString = "";

//		for (int i = 0; i < groups.Count; i++)
//		{
//			Group group = (Group)groups[i];
//			returnString += group.Convert();
//		}

//		return returnString;
//	}
//}

///// <summary>
///// Builds an object for a group
///// Contains the name of the group(title) and the pages in that group
///// </summary>
//class Group
//{
//	private string Title;
//	private ArrayList Pages = new ArrayList();

//	public Group(string title)
//	{
//		Title = title;
//	}

//	public void AddMember(string page)
//	{
//		Pages.Add(page);
//	}

//	public string Convert()
//	{
//		string returnString = Title + ",";

//		foreach (string page in Pages)
//		{
//			returnString += page + ",";
//		}

//		returnString += ";";

//		return returnString;
//	}
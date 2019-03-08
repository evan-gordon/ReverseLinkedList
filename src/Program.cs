using System;

namespace src
{
  public class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
    }

    public static ListNode ReverseList(ListNode head)
    {
      if (head == null || head.next == null)
      {
        return head;
      }
      return RecReverseList(ref head, ref head.next);
    }

    public static ListNode RecReverseList(ref ListNode currHead, ref ListNode nextNode)
    {
      if (nextNode == null)
      {
        return currHead;
      }
      else
      {
        var tmp = currHead;
        currHead = nextNode;
        nextNode = currHead.next;
        currHead.next = tmp;
        return RecReverseList(ref currHead, ref nextNode);
      }
    }
  }

  public class ListNode
  {
    public int val;
    public ListNode next;
    public ListNode(int x) { val = x; }
  }
}

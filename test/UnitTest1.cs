using System;
using Xunit;
using src;

namespace test
{
  public class UnitTest1
  {
    [Fact]
    public void Test1()
    {
      ListNode one = new ListNode(1);
      ListNode two = new ListNode(2);
      ListNode three = new ListNode(3);
      ListNode four = new ListNode(4);
      ListNode five = new ListNode(5);
      one.next = two;
      two.next = three;
      three.next = four;
      four.next = five;

      var ln = Program.ReverseList(one);
      Assert.Equal(5, ln.val);
    }
  }
}

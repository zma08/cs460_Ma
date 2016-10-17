﻿using System;
/**
 * A singly linked stack implementation.
 */
namespace PostFixedCalculator
{
    public class LinkedStack : StackADT
    {
        private Node top;
        public LinkedStack()
        {
            top = null; //empty stack 
        }
        public void clear()
        {
            top = null;
        }

        public  bool isEmpty()
        {
            return (top == null ? true : false);
        }

        public Object peek()
        {
            return (isEmpty() ? null : top.data);
        }

        public Object pop()
        {
            if (top == null) { return null; }
            Object item = top.data;
            top = top.next;
            return item;
        }

        public Object push(Object newItem)
        {
            if (newItem == null) { return null; }
            Node aNode = new Node(newItem, top);
            top = aNode;
            return newItem;
        }
    }


}
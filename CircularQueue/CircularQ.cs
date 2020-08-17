using System;


namespace CircularQueue
{
    class CircularQ
    {
        private int[] CircQA;
        private int front;
        private int rear;

        public CircularQ()
        {
            CircQA = new int[10];
            front = -1;
            rear = -1;
        }

        public CircularQ(int maxSize)
        {
            CircQA = new int[maxSize];
            front = -1;
            rear = -1;
        }
        public bool isEmpty()
        {
            return (front == -1);
        }

        public bool isFull()
        {
            return ((front == 0 && rear == CircQA.Length - 1) || (front == rear + 1));
        }

        public int Insert(int x)
        {
            if (isFull())
                throw new System.InvalidOperationException("Queue Overflow");
            if (front == -1)
                front = 0;
            if (rear == CircQA.Length - 1)
                rear = 0;
            else
                rear = rear + 1;
            CircQA[rear] = x;
            return x;
        }

        public int Delete()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            int x = CircQA[front];

            if(front == rear)            /*Queue has one element*/
            {
                front = -1;
                rear = -1;
            }
            if (front == CircQA.Length - 1)
                front = 0;
            else
                front = front + 1;
            return x;
        }

        public int Peek()
        {
            if (isEmpty())
                throw new System.InvalidOperationException("Queue Underflow");
            return CircQA[front];
        }

        public void Display()
        {
            if (front == -1)
                Console.WriteLine("Queue is Empty");
            int i = front;
            if(front<=rear)
            {
                while (i <= rear)
                    Console.WriteLine(CircQA[i++] +" ");
            }
            else
            {
                while (i <= CircQA.Length - 1)
                    Console.WriteLine(CircQA[i++] + " ");
                i = 0;
                while (i <= rear)
                    Console.WriteLine(CircQA[i++] + " ");
            }
            Console.WriteLine("");
        }

        public int Size()
        {
            if (isEmpty())
                Console.WriteLine("Queue is Empty");
            if (isFull())
                Console.WriteLine(CircQA.Length - 1);
            int i = front;
            int s = 0; ;
            if(front<=rear)
            {
                while(i<=rear)
                {
                    s++;
                    i++;
                }
            }
            else
            {
                while (i <= CircQA.Length - 1)
                {
                    s++;
                    i++;
                }
                i = 0;
                while (i <= rear)
                {
                    s++;
                    i++;
                }
            }
            return s;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TodoIt.Test
{
    public class TestTodoItems
    {
        private readonly TodoItems todoItems1;
        private readonly TodoItems todoItems2;
        private readonly int size;

        public TestTodoItems()
        {
            TodoSequencer.Reset();
            
            todoItems1 = new TodoItems();
            todoItems2 = new TodoItems();

            todoItems1.Clear();

            size = 6;
            MassAdd(size / 2, todoItems1);
            MassAdd(size / 2, todoItems2);
            
        }

        private void MassAdd(int size, TodoItems todoItems)
        {
            for (int i = 0; i < size; i++)
                todoItems.AddTodo($"Todo {i}");
        }

        [Fact]
        public void TestSize()
        {
            Assert.Equal(size, todoItems1.Size());
            Assert.Equal(size, todoItems2.Size());
        }

        [Fact]
        public void TestReturnAllAndFindById()
        {
            Todo[] todos = todoItems1.FindAll();

            for (int i = 0; i < todos.Length; i++)
            {
                Assert.Equal(todos[i], todoItems1.FindById(i));
            }
        }

        [Fact]
        public void TestAddTodo()
        {
            string expected = "Description";
            todoItems1.AddTodo(expected);

            Assert.Equal(
                expected,
                todoItems1.FindById(todoItems1.Size() - 1).Decription);
        }

        [Fact]
        public void TestClear()
        {
            todoItems1.Clear();

            Assert.Equal(0, todoItems1.Size());
        }

        [Fact]
        public void TestFindByIdThrowsException()
        {
            Assert.Throws<Exception>(() => todoItems1.FindById(100));
        }
    }
}

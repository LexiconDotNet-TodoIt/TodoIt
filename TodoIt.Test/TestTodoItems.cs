using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace TodoIt.Test
{
    public class TestTodoItems
    {
        private readonly TodoItems todoItems;
        private readonly int size;

        public TestTodoItems()
        {
            TodoSequencer.Reset();
            
            todoItems = new TodoItems();
            todoItems.Clear();

            size = 5;
            for (int i = 0; i < size; i++)
                todoItems.AddTodo($"Todo {i}");
        }

        [Fact]
        public void TestSize()
        {
            Assert.Equal(size, todoItems.Size());
        }

        [Fact]
        public void TestReturnAllAndFindById()
        {
            Todo[] todos = todoItems.FindAll();

            for (int i = 0; i < todos.Length; i++)
            {
                Assert.Equal(todos[i], todoItems.FindById(i));
            }
        }

        [Fact]
        public void TestAddToDo()
        {
            string expected = "Description";
            todoItems.AddTodo(expected);

            Assert.Equal(
                expected,
                todoItems.FindById(todoItems.Size() - 1).Decription);
        }

        [Fact]
        public void TestClear()
        {
            todoItems.Clear();

            Assert.Equal(0, todoItems.Size());
        }

        [Fact]
        public void TestArrayStatic()
        {
            Todo
        }

    }
}

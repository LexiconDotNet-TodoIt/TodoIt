using System;
using System.Linq;

namespace TodoIt
{
    public class TodoItems
    {
        private static Todo[] todoItems = new Todo[0];

        public int Size()
        {
            return todoItems.Length;
        }

        public Todo[] FindAll()
        {
            return todoItems;
        }

        public Todo FindById(int todoId)
        {
            foreach (Todo todo in todoItems)
                if (todo.TodoId == todoId)
                    return todo;

            throw new Exception("No Todo with that Id found.");
        }

        public Todo AddTodo(string description)
        {
            Todo todo = new Todo(TodoSequencer.NextTodoId(), description);
            todoItems = todoItems.Append<Todo>(todo).ToArray();
            return todo;
        }

        public void Clear()
        {
            todoItems = new Todo[0];
        }
    }
}

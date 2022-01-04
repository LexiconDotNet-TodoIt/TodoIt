using System;

namespace TodoIt
{
    internal class TodoItems
    {
        private static Todo[] todoItems = new Todo[0];

        public int Size()
        {
            return todoItems.Length;
        }

        public Todo[] FindAll()
        {
            Todo[] todoItemsToFind = new Todo[todoItems.Length];
            todoItems.CopyTo(todoItemsToFind, 0);

            return todoItemsToFind; 
        }

        public Todo FindById(int todoId)
        {
            Todo todo = null;
            foreach (Todo item in todoItems)
            { 
                if(item.TodoId == todoId)
                    todo = item;    
            }
            if (todo == null)
                throw new Exception("Hitta inget element");

            return todo;
        }

        public Todo AddTodo(string description)
        {
            Todo todo = new Todo(TodoSequencer.NextTodoId(), description);
            Todo []tempArray = new Todo[Size() + 1];
            todoItems.CopyTo(tempArray, 0);
            tempArray[tempArray.Length] = todo;
            todoItems = tempArray;
            return todo;
        }
        public void Clear()
        {
            todoItems = new Todo[0];
        }

    }
}

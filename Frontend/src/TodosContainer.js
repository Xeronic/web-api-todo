import React, { useState, useEffect } from "react";
import { api } from "../rest";

import TodoList from "./TodoList";
import AddTodo from "./AddTodo";

export default () => {
  const [todos, setTodos] = useState([]);

  useEffect(
    () => {
      updateTodos();
    },
    [true]
  );

  function updateTodos() {
    api
      .get("https://localhost:5001/api/todolists")
      .then(result => result.json())
      .then(json => setTodos(json));
  }

  return (
    <div>
      <AddTodo updateTodos={updateTodos} />
      <TodoList todos={todos} />
    </div>
  );
};

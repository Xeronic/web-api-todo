import React, { useState, useEffect } from "react";
import { api } from "../rest";

export default props => {
  function handleClick(todo) {
    document.location = "https://localhost:5001/api/todolists/" + todo.id;
  }

  const todosMarkup = props.todos.map((todo, index) => (
    <li key={index} onClick={() => handleClick(todo)}>
      {todo.title}
    </li>
  ));
  return <ul>{todosMarkup}</ul>;
};

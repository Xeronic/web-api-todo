import React, { useState, useEffect } from "react";
import { api } from "../rest";

export default props => {
  const [todo, setTodo] = useState("");

  function handleClick() {
    api
      .post("https://localhost:5001/api/todolists", {
        title: todo
      })
      .then(result => {
        setTodo("");
        props.updateTodos();
      });
  }

  return [
    <input value={todo} onChange={e => setTodo(e.target.value)} />,
    <button onClick={() => handleClick()}>Submit</button>
  ];
};

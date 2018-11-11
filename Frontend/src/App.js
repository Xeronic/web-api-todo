import React from "react";

import TodoList from "./TodoList";
import AddTodo from "./AddTodo";
import TodosContainer from "./TodosContainer";

export default class App extends React.Component {
  constructor(props) {
    super(props);
  }

  render() {
    return <TodosContainer />;
  }
}

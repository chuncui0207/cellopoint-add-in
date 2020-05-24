import * as React from "react";
import { Button, ButtonType } from "office-ui-fabric-react";

export default class App extends React.Component {
  constructor(props, context) {
    super(props, context);
    this.state = {
    };
  }

  componentDidMount() {}

  click = async () => {
    /**
     * Insert your Outlook code here
     */
  };

  render() {
    return (
      <div className="ms-welcome">
        登录页面
      </div>
    );
  }
}

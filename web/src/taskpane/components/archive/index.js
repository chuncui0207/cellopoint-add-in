import * as React from "react";
import { Button, ButtonType } from "office-ui-fabric-react";

export default class Archive extends React.Component {
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
        <h3>归档区</h3>
        数据来源 Cellopoint restful api
      </div>
    );
  }
}

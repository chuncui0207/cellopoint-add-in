import * as React from "react";
import { Button, ButtonType } from "office-ui-fabric-react";

export default class Settings extends React.Component {
  constructor(props, context) {
    super(props, context);
    this.state = {};
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
        <h3>偏好设置</h3>
        数据来源 Cellopoint add-in restful api
      </div>
    );
  }
}

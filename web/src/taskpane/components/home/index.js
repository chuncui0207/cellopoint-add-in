import * as React from "react";
import { Button, ButtonType, OverflowSet, Link } from "office-ui-fabric-react";
import { fetchFolders } from "../../../api/folder";
import { fetchMessages } from "../../../api/message";
import EmailDetailsList from "./EmailDetailsList";

export default class App extends React.Component {
  constructor(props, context) {
    super(props, context);

    this.state = {
      pagedMessages: []
    };
  }

  componentDidMount() {
    fetchMessages("Inbox").then(response => {
      this.setState({ pagedMessages: response.data.value });
    });
  }

  handleNavHandler(path) {}

  render() {
    const onRenderOptItem = item => {
      return (
        <Link role="menuitem" styles={{ root: { marginRight: 10 } }} onClick={item.onClick}>
          {item.name}
        </Link>
      );
    };

    return (
      <div className="ms-welcome">
        <div style={{ borderTop: "1px solid #ccc", padding: "10px 0", display: "flex", justifyContent: "flex-end" }}>
          <div>
            <OverflowSet
              aria-label="Basic Menu Example"
              role="menubar"
              items={[
                {
                  key: "item1",
                  name: "回报漏栏"
                },
                {
                  key: "item2",
                  name: "回报漏栏拉黑"
                },
                {
                  key: "item3",
                  name: "过滤"
                }
              ]}
              onRenderItem={onRenderOptItem}
            />
          </div>
        </div>

        <div style={{ borderTop: "1px solid #ccc" }}>
          <EmailDetailsList items={this.state.pagedMessages} />
        </div>
      </div>
    );
  }
}

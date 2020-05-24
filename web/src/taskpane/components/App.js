import * as React from "react";
import { HashRouter as Router, Route, Switch, Link as RouteLink } from "react-router-dom";
import { OverflowSet, Link } from "office-ui-fabric-react";
import Progress from "./Progress";

import Login from "./login";
import Home from "./home";
import Quarantine from "./quarantine";
import Archive from "./archive";
import Settings from "./settings";

export default class App extends React.Component {
  constructor(props, context) {
    super(props, context);
    this.state = {};
  }

  componentDidMount() {}

  render() {
    const { title, isOfficeInitialized } = this.props;

    if (!isOfficeInitialized) {
      return (
        <Progress title={title} logo="assets/logo-filled.png" message="Please sideload your addin to see app body." />
      );
    }

    const onRenderNavItem = item => {
      return (
        <RouteLink to={item.path}>
          <Link role="menuitem" styles={{ root: { marginRight: 10 } }} onClick={item.onClick}>
            {item.name}
          </Link>
        </RouteLink>
      );
    };

    return (
      <Router>
        <div style={{ padding: "10px 0", borderTop: "1px solid #ccc" }}>
          <div style={{ padding: "0 10px" }}>
            <div style={{ display: "flex", justifyContent: "space-between" }}>
              <OverflowSet
                aria-label="Basic Menu Example"
                role="menubar"
                items={[
                  {
                    key: "item1",
                    name: "回报区",
                    path: "/"
                  },
                  {
                    key: "item2",
                    name: "隔离区",
                    path: "/quarantine"
                  },
                  {
                    key: "item3",
                    name: "归档区",
                    path: "/archive"
                  }
                ]}
                onRenderItem={onRenderNavItem}
              />
              <RouteLink to="/settings">
                <Link>偏好设置</Link>
              </RouteLink>
            </div>
          </div>
        </div>
        <Switch>
          <Route path="/login">
            <Login />
          </Route>
          <Route path="/quarantine">
            <Quarantine />
          </Route>
          <Route path="/Archive">
            <Archive />
          </Route>
          <Route path="/settings">
            <Settings />
          </Route>
          <Route path="/">
            <Home />
          </Route>
        </Switch>
      </Router>
    );
  }
}

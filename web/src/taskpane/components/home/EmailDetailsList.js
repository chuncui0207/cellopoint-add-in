import * as React from "react";
import { Link, DetailsList, buildColumns } from "office-ui-fabric-react";

export default class EmailDetailsList extends React.Component {
  constructor(props, context) {
    super(props, context);
    this.state = {
      columns: buildColumns([{ Subject: "" }])
    };
  }

  componentDidMount() {}

  handleColumnClick() {}

  render() {
    const { columns } = this.state;
    const { items } = this.props;

    const renderItemColumn = (item, index, column) => {
      column.isMultiline = true;
      return (
        <div>
          <div>
            <b>{item.Subject}</b>
          </div>
          <div>
            {item.Sender.EmailAddress.Name} . {item.SentDateTime}
          </div>
        </div>
      );
    };

    return (
      <DetailsList
        isHeaderVisible={false}
        items={items}
        setKey="set"
        checkboxVisibility={1}
        columns={columns}
        onRenderItemColumn={renderItemColumn}
        onColumnHeaderClick={this.handleColumnClick}
        ariaLabelForSelectionColumn="Toggle selection"
        ariaLabelForSelectAllCheckbox="Toggle selection for all items"
        checkButtonAriaLabel="Row checkbox"
      />
    );
  }
}

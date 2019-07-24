import React, { Component } from 'react';
import MiniDrawer from './components/MenuSide/Menu';
//simport SignIn from './components/signIn';
export default class App extends Component {
  displayName = App.name

  render() {
      return (
          <div>
              <MiniDrawer />
            {/* <EnfantForm/> */}
          </div>
    );
  }
}

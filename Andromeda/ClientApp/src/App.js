import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './pages/Layout';
import { Home } from './pages/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';

export default class App extends Component {
  displayName = App.name

  render() {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
        <Route path='/fetchdata' component={FetchData} />
      </Layout>
    );
  }
}

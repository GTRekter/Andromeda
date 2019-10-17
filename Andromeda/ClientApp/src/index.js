import 'jquery/src/jquery';
import 'font-awesome/css/font-awesome.min.css';
import 'materialize-css/dist/css/materialize.min.css';
import 'owl.carousel/dist/assets/owl.carousel.css';
import './grid.css';
import './index.css';

import React from 'react';
import ReactDOM from 'react-dom';
import { BrowserRouter } from 'react-router-dom';
import App from './App';
import registerServiceWorker from './registerServiceWorker';

const baseUrl = document.getElementsByTagName('base')[0].getAttribute('href');
const rootElement = document.getElementById('root');

ReactDOM.render(
  <BrowserRouter basename={baseUrl}>
    <App />
  </BrowserRouter>,
  rootElement);

registerServiceWorker();

import React from 'react';
import ReactDOM from 'react-dom';
import './index.css';
import * as serviceWorker from './serviceWorker';
import LifecycleDemo from './LifecycleDemo';
import Hello2 from './Hello2';

ReactDOM.render(
  <React.StrictMode>
    <LifecycleDemo />
    <Hello2 />
  </React.StrictMode>,
  document.getElementById('root')
);

// If you want your app to work offline and load faster, you can change
// unregister() to register() below. Note this comes with some pitfalls.
// Learn more about service workers: https://bit.ly/CRA-PWA
serviceWorker.unregister();

import React from 'react';
import logo from './logo.svg';
import { Counter } from './features/counter/Counter';
import './App.css';
import RouterCustom from './routes';

function App() {
  return (
    <React.Fragment>
    
      <div className="font-sora w-screen h-screen pl-4 pr-4 pt-6 bg-gradient-to-b from-purple-900 to-purple-700 text-white">
        <RouterCustom/>
      </div>
    
  </React.Fragment>

  );
}

export default App;

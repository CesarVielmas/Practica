import React from 'react';
import { Contador } from './Components/Basico1/Contador';
import { CallBack } from './Components/Basico2/CallBack';
import { Memo } from './Components/Basico3/UseMemo';

function App() {
  return (
    <div >
      <Contador/>
      <hr/>
      <CallBack/>
      <hr/>
      <Memo/>
    </div>
  );
}

export default App;

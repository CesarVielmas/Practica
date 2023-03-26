import React from 'react'

export default function Main({tema,idioma,auth}) {
  return (
    <main className={tema}>
      {auth?<h2>{idioma.main2H2}</h2>:<h2>{idioma.main1H2}</h2>}    
        <p>{idioma.mainP}</p>
    </main>
  )
}

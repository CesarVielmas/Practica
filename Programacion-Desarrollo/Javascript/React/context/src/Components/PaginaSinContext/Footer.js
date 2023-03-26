import React from 'react'

export default function Footer({tema,idioma}) {
  return (
    <footer className={tema}>
        <p>{idioma.footerP}</p>
    </footer>
  )
}

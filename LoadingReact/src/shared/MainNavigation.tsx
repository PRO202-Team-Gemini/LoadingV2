/* TODO - HUSK Å TA BORT */
import { Link } from "react-router-dom";

const MainNavigation = () => {
  return (
    <nav>
      <div>
        <ul>
          <Link to="landingPage"> Landingsside </Link>
          <Link to="turnPhonePage">Turn</Link>

          <Link to="signIn"> Sign in </Link>

          <Link to="waiting-room">Loading Players</Link>

          <Link to="wait">Wait</Link>

          <Link to="option">Option</Link>

          <Link to="result">Result</Link>

          <Link to="stats">Stats</Link>

          <Link to="map">Map</Link>

          <Link to="feedback">Feedback</Link>
        </ul>
      </div>
    </nav>
  );
};

export default MainNavigation;

import React from "react";

import { ParagraphProps } from "./ParagraphProps";

import styles from "./Paragraph.module.css";

/**
 * ### Paragraph just copied p tag
 * 
 * @param {string} fontSize - font size may be px, em, rem an other. Default __1.5rem__.
 * @param {string} color - hex value like this __"#FFFFF"__.
 * @param {string} styleType - paragraph variants. avaiable types is AvaiableStyles.
 * @param {boolean} frozen - make text uncoping. Default __false__.
 * 
 * @example
 * <Paragraph>Some text</Paragraph>
 * <Paragraph fontSize="2rem">Some text</Paragraph>
 * <Paragraph fontSize="1.5rem" color="#FF0000" frozen>Boring some text 😴</Paragraph>
 */
const Paragraph: React.FC<ParagraphProps> = ({ fontSize, color, styleType, frozen, children }) => {
  const paragraphClassName = !!styleType ? styles[styleType] : styles.Paragraph1
  const paragraphFontSize = !!fontSize ? fontSize : "1.5rem"
  const paragraphColor = !!color ? color : "#333333"

  return <p
    className={`${paragraphClassName} ${frozen ? styles.Frozen : " "}`}
    style={{
      color: paragraphColor,
      fontSize: paragraphFontSize
    }}
    >
      {children}
    </p>
};

export default Paragraph;

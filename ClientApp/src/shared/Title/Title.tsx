import React from "react";

import { TitleProps } from "./Title.props";

import styles from "./Title.module.css";

/**
 * ### Title just copied h1-6
 * 
 * @param {number} size - (h)eader size, avaiable sizes 1-6. Default size is 1.
 * @param {string} color - hex value like this "#FFFFF".
 * @param {string} styleType - (h)eader variants. avaiable types is AvaiableStyles.
 * 
 * @example
 * <Title>Some text</Title>
 * <Title size={2} color="#2F2F2F">Super some text</Title>
 */
const Title: React.FC<TitleProps> = ({ size, color, styleType, children }) => {
  const TitleTag = `h${size || 1}` as keyof JSX.IntrinsicElements;  // default size=1 if undefind

  const titleClassName = !!styleType ? styles[styleType] : styles.Title1;
  const titleColor = !!color ? color : '#333333'  // TODO: make global vars

  return <TitleTag
      className={titleClassName}
      style={{color: titleColor}}
      >
    {children}
  </TitleTag>
};

export default Title;

enum AvaiableStyles {
    // Maybe make more specific styles like: Bold, Medium, Light or Secondary, Primary 🤔
    Title1 = 'title1',
}

export interface TitleProps {
    size?: 1 | 2 | 3 | 4 | 5 | 6
    color?: string
    styleType?: AvaiableStyles
    children: React.ReactNode
}

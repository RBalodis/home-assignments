import React, { HTMLAttributes, ReactNode } from 'react';
import classnames from 'classnames';

export interface DesktopMenuListProps {
    children: ReactNode;
    className?: HTMLAttributes<HTMLUListElement>['className'];
}

export const DesktopMenuList = ({
    children,
    className,
}: DesktopMenuListProps) => {
    return (
        <ul className={classnames('if desktop-menu-list', className)}>
            {children}
        </ul>
    );
};

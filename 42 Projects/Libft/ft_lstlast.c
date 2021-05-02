/* ************************************************************************** */
/*                                                                            */
/*                                                        :::      ::::::::   */
/*   ft_lstlast.c                                       :+:      :+:    :+:   */
/*                                                    +:+ +:+         +:+     */
/*   By: mfeijao <marvin@42.fr>                     +#+  +:+       +#+        */
/*                                                +#+#+#+#+#+   +#+           */
/*   Created: 2021/03/01 11:41:24 by mfeijao           #+#    #+#             */
/*   Updated: 2021/03/01 11:42:01 by mfeijao          ###   ########.fr       */
/*                                                                            */
/* ************************************************************************** */

#include "libft.h"

t_list	*ft_lstlast(t_list *list)
{
	t_list *temp;

	temp = list;
	if (temp)
	{
		while (temp->next)
			temp = temp->next;
		return (temp);
	}
	return (NULL);
}
